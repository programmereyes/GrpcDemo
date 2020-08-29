rem protoc.exe -I=.\Protos --csharp_out .\Grpc\Messages .\Protos\Employee.proto --grpc_out .\Grpc\Messages --plugin=protoc-gen-grpc="C:\Users\Aditya\.nuget\packages\grpc.tools\0.7.0\tools\grpc_csharp_plugin.exe"

rem protoc --proto_path=.\ --csharp_out=.\ --csharp_opt=file_extension=.cs,base_namespace=EmployeeMessages .\Protos\Employee.proto

rem set TOOLS_PATH="C:\Users\Aditya\Downloads\protoc-3.13.0-win64\bin"

rem %TOOLS_PATH%\protoc.exe --proto_path=.\ --csharp_out=.\ --csharp_opt=file_extension=.cs,base_namespace=EmployeeMessages .\Protos\Employee.proto

rem %TOOLS_PATH%\protoc.exe .\Protos\Employee.proto --grpc_out=.\  --plugin=protoc-gen-grpc=Plugins\grpc_csharp_plugin.exe 

rem protoc.exe --proto_path=.\ --csharp_out=.\ --csharp_opt=file_extension=.cs,base_namespace=EmployeeMessages .\Protos\Employee.proto

rem protoc.exe --proto_path=.\ .\Protos\Employee.proto --grpc_out=.\  --plugin=protoc-gen-grpc=Plugins\grpc_csharp_plugin.exe 


set TOOLS_PATH="C:\Users\Aditya\Desktop\GrpcExample\EmployeeManagement\EmployeeMessages\Plugins\grpc_2.31.0_x64"

%TOOLS_PATH%\protoc.exe --proto_path=.\ --csharp_out=.\ --csharp_opt=file_extension=.cs,base_namespace=EmployeeMessages .\Protos\Employee.proto

%TOOLS_PATH%\protoc.exe .\Protos\Employee.proto --grpc_out=.\  --plugin=protoc-gen-grpc=Plugins\grpc_csharp_plugin.exe 
