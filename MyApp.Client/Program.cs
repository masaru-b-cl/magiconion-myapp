﻿using System;

using Grpc.Net.Client;
using MagicOnion.Client;
using MyApp.Shared;

// Connect to the server using gRPC channel.
var channel = GrpcChannel.ForAddress("http://localhost:5000");

// Create a proxy to call the server transparently.
var client = MagicOnionClient.Create<IMyFirstService>(channel);

// Call the server-side method using the proxy.
var result = await client.SumAsync(123, 456);
Console.WriteLine($"Result: {result}");