﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoOrm.Extensions;

namespace NoOrm
{
    public partial class NoOrm
    {
        public async Task<IEnumerable<(string name, object value)>> SingleAsync(string command)
        {
            await using var cmd = Connection.CreateCommand();
            SetCommand(cmd, command);
            await Connection.EnsureIsOpenAsync();
            await using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync()
                ? reader.ToTuples().ToList()
                : new List<(string name, object value)>();
        }

        public async Task<IEnumerable<(string name, object value)>> SingleAsync(string command, params object[] parameters)
        {
            await using var cmd = Connection.CreateCommand();
            SetCommand(cmd, command);
            await Connection.EnsureIsOpenAsync();
            cmd.AddParameters(parameters);
            await using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync() 
                ? reader.ToTuples().ToList()
                : new List<(string name, object value)>();
        }

        public async Task<IEnumerable<(string name, object value)>> SingleAsync(string command, params (string name, object value)[] parameters)
        {
            await using var cmd = Connection.CreateCommand();
            SetCommand(cmd, command);
            await Connection.EnsureIsOpenAsync();
            cmd.AddParameters(parameters);
            await using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync()
                ? reader.ToTuples().ToList()
                : new List<(string name, object value)>();
        }
    }
}