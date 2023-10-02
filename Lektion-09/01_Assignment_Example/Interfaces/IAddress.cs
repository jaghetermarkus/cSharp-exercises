﻿namespace _01_Assignment_Example.Interfaces;

public interface IAddress
{
    string? StreetName { get; set; }
    string? StreetNumber { get; set; }
    string? PostalCode { get; set; }
    string? City { get; set; }

    string? FullAddress { get; }
}