﻿namespace Cedar.Commands.Client
{
    public interface ICommandExecutionSettings
    {
        string Vendor { get; }

        IModelToExceptionConverter ModelToExceptionConverter { get; }

        string Path { get; }
    }
}