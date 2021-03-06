::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

REM @echo off
set autoRestVersion=0.17.3
if  "%1" == "" (
    set specFile="https://raw.githubusercontent.com/Azure/azure-rest-api-specs/master/arm-sql/compositeSql.json" 
) else (
    set specFile="%1"
)
set repoRoot=%~dp0..\..\..\..\
set generateFolder=%~dp0Generated

if exist %generateFolder% rd /S /Q  %generateFolder%
set namespace=Microsoft.Azure.Management.Sql
"%repoRoot%packages\AutoRest.%autoRestVersion%\tools\autorest.exe" -Namespace %namespace% -Input %specFile% -Modeler CompositeSwagger -OutputDirectory %generateFolder% -CodeGenerator Azure.CSharp -AddCredentials true
