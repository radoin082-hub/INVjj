﻿namespace INV.Domain.Shared;

public class Result
{
    public bool Successed { get; set; }
    public string[] Errors { get; set; }
    public List<ErrorCode> ErrorCodes { get; set; }

    private Result(bool success, string[] errors = null)
    {
        Successed = success;
        Errors = errors;
    }

    private Result(bool success, List<ErrorCode> errors = null)
    {
        Successed = success;
        ErrorCodes = errors;
    }

    private Result()
    {
        Successed = true;
    }

    public static Result Succes => new Result();

    public static Result Failure(string[] errors) =>
        new Result(false, errors);

    public static Result Failure(List<ErrorCode> errors) =>
        new Result(false, errors);
}