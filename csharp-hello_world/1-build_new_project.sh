#!/usr/bin/env bash
# this is gonna initialize a new project

dotnet new console -o 1-new_project -f "netcoreapp2.1"
dotnet build "1-new_project"
