﻿using System;

namespace AudioSwitcher.Scripting
{
    public class ExecutionResult
    {
        public bool Success
        {
            get;
            set;
        }

        public Exception ExecutionException
        {
            get;
            set;
        }
    }

    public sealed class ExecutionResult<T> : ExecutionResult
    {

        public ExecutionResult()
        {
            
        }

        public ExecutionResult(T value)
        {
            Value = value;
        }

        public T Value
        {
            get;
            set;
        }

    }
}