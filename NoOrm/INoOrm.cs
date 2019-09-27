﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace NoOrm
{
    public interface INoOrm :
        INoOrmExecute, 
        INoOrmExecuteAsync,
        INoOrmSingle, 
        INoOrmSingleAsync,
        INoOrmRead,
        INoOrmReadAsync
    {
        DbConnection Connection { get; }
        INoOrm As(CommandType type);
        INoOrm Timeout(int? timeout);
    }
    
    public interface INoOrmExecute
    {
        INoOrm Execute(string command);
        INoOrm Execute(string command, params object[] parameters);
        INoOrm Execute(string command, params (string name, object value)[] parameters);
    }

    public interface INoOrmExecuteAsync
    {
        Task<INoOrm> ExecuteAsync(string command);
        Task<INoOrm> ExecuteAsync(string command, params object[] parameters);
        Task<INoOrm> ExecuteAsync(string command, params (string name, object value)[] parameters);
    }

    public interface INoOrmSingle
    {
        IEnumerable<(string name, object value)> Single(string command);
        IEnumerable<(string name, object value)> Single(string command, params object[] parameters);
        IEnumerable<(string name, object value)> Single(string command, params (string name, object value)[] parameters);
        T Single<T>(string command);
        T Single<T>(string command, params object[] parameters);
        T Single<T>(string command, params (string name, object value)[] parameters);
        (T1, T2) Single<T1, T2>(string command);
        (T1, T2) Single<T1, T2>(string command, params object[] parameters);
        (T1, T2) Single<T1, T2>(string command, params (string name, object value)[] parameters);
        (T1, T2, T3) Single<T1, T2, T3>(string command);
        (T1, T2, T3) Single<T1, T2, T3>(string command, params object[] parameters);
        (T1, T2, T3) Single<T1, T2, T3>(string command, params (string name, object value)[] parameters);
        (T1, T2, T3, T4) Single<T1, T2, T3, T4>(string command);
        (T1, T2, T3, T4) Single<T1, T2, T3, T4>(string command, params object[] parameters);
        (T1, T2, T3, T4) Single<T1, T2, T3, T4>(string command, params (string name, object value)[] parameters);
        (T1, T2, T3, T4, T5) Single<T1, T2, T3, T4, T5>(string command);
        (T1, T2, T3, T4, T5) Single<T1, T2, T3, T4, T5>(string command, params object[] parameters);
        (T1, T2, T3, T4, T5) Single<T1, T2, T3, T4, T5>(string command, params (string name, object value)[] parameters);
    }

    public interface INoOrmSingleAsync
    {
        Task<IEnumerable<(string name, object value)>> SingleAsync(string command);
        Task<IEnumerable<(string name, object value)>> SingleAsync(string command, params object[] parameters);
        Task<IEnumerable<(string name, object value)>> SingleAsync(string command, params (string name, object value)[] parameters);
        Task<T> SingleAsync<T>(string command);
        Task<T> SingleAsync<T>(string command, params object[] parameters);
        Task<T> SingleAsync<T>(string command, params (string name, object value)[] parameters);
        Task<(T1, T2)> SingleAsync<T1, T2>(string command);
        Task<(T1, T2)> SingleAsync<T1, T2>(string command, params object[] parameters);
        Task<(T1, T2)> SingleAsync<T1, T2>(string command, params (string name, object value)[] parameters);
        Task<(T1, T2, T3)> SingleAsync<T1, T2, T3>(string command);
        Task<(T1, T2, T3)> SingleAsync<T1, T2, T3>(string command, params object[] parameters);
        Task<(T1, T2, T3)> SingleAsync<T1, T2, T3>(string command, params (string name, object value)[] parameters);
        Task<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(string command);
        Task<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(string command, params object[] parameters);
        Task<(T1, T2, T3, T4)> SingleAsync<T1, T2, T3, T4>(string command, params (string name, object value)[] parameters);
        Task<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(string command);
        Task<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(string command, params object[] parameters);
        Task<(T1, T2, T3, T4, T5)> SingleAsync<T1, T2, T3, T4, T5>(string command, params (string name, object value)[] parameters);
    }

    public interface INoOrmRead
    {
        IEnumerable<IEnumerable<(string name, object value)>> Read(string command);
        IEnumerable<IEnumerable<(string name, object value)>> Read(string command, params object[] parameters);
        IEnumerable<IEnumerable<(string name, object value)>> Read(string command, params (string name, object value)[] parameters);
        IEnumerable<T> Read<T>(string command);
        IEnumerable<T> Read<T>(string command, params object[] parameters);
        IEnumerable<T> Read<T>(string command, params (string name, object value)[] parameters);
        IEnumerable<(T1, T2)> Read<T1, T2>(string command);
        IEnumerable<(T1, T2)> Read<T1, T2>(string command, params object[] parameters);
        IEnumerable<(T1, T2)> Read<T1, T2>(string command, params (string name, object value)[] parameters);
        IEnumerable<(T1, T2, T3)> Read<T1, T2, T3>(string command);
        IEnumerable<(T1, T2, T3)> Read<T1, T2, T3>(string command, params object[] parameters);
        IEnumerable<(T1, T2, T3)> Read<T1, T2, T3>(string command, params (string name, object value)[] parameters);
        IEnumerable<(T1, T2, T3, T4)> Read<T1, T2, T3, T4>(string command);
        IEnumerable<(T1, T2, T3, T4)> Read<T1, T2, T3, T4>(string command, params object[] parameters);
        IEnumerable<(T1, T2, T3, T4)> Read<T1, T2, T3, T4>(string command, params (string name, object value)[] parameters);
        IEnumerable<(T1, T2, T3, T4, T5)> Read<T1, T2, T3, T4, T5>(string command);
        IEnumerable<(T1, T2, T3, T4, T5)> Read<T1, T2, T3, T4, T5>(string command, params object[] parameters);
        IEnumerable<(T1, T2, T3, T4, T5)> Read<T1, T2, T3, T4, T5>(string command, params (string name, object value)[] parameters);

    }

    public interface INoOrmReadAsync
    {
        IAsyncEnumerable<IAsyncEnumerable<(string name, object value)>> ReadAsync(string command);
        IAsyncEnumerable<IAsyncEnumerable<(string name, object value)>> ReadAsync(string command, params object[] parameters);
        IAsyncEnumerable<IAsyncEnumerable<(string name, object value)>> ReadAsync(string command, params (string name, object value)[] parameters);
        IAsyncEnumerable<T> ReadAsync<T>(string command);
        IAsyncEnumerable<T> ReadAsync<T>(string command, params object[] parameters);
        IAsyncEnumerable<T> ReadAsync<T>(string command, params (string name, object value)[] parameters);
        IAsyncEnumerable<(T1, T2)> ReadAsync<T1, T2>(string command);
        IAsyncEnumerable<(T1, T2)> ReadAsync<T1, T2>(string command, params object[] parameters);
        IAsyncEnumerable<(T1, T2)> ReadAsync<T1, T2>(string command, params (string name, object value)[] parameters);


        IAsyncEnumerable<(T1, T2, T3)> ReadAsync<T1, T2, T3>(string command);
        IAsyncEnumerable<(T1, T2, T3)> ReadAsync<T1, T2, T3>(string command, params object[] parameters);
        IAsyncEnumerable<(T1, T2, T3)> ReadAsync<T1, T2, T3>(string command, params (string name, object value)[] parameters);


        IAsyncEnumerable<(T1, T2, T3, T4)> ReadAsync<T1, T2, T3, T4>(string command);
        IAsyncEnumerable<(T1, T2, T3, T4)> ReadAsync<T1, T2, T3, T4>(string command, params object[] parameters);
        IAsyncEnumerable<(T1, T2, T3, T4)> ReadAsync<T1, T2, T3, T4>(string command, params (string name, object value)[] parameters);


        IAsyncEnumerable<(T1, T2, T3, T4, T5)> ReadAsync<T1, T2, T3, T4, T5>(string command);
        IAsyncEnumerable<(T1, T2, T3, T4, T5)> ReadAsync<T1, T2, T3, T4, T5>(string command, params object[] parameters);
        IAsyncEnumerable<(T1, T2, T3, T4, T5)> ReadAsync<T1, T2, T3, T4, T5>(string command, params (string name, object value)[] parameters);

    }
}
