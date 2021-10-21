# BPM Tool Lab2 Development activities

This repository is a part of Software Quality IDY0204 Lab2 Development activities.  
Team BPM Tool, IVSM11:

1. Worraanong Chanchaijak
1. Matin Manafov
1. Ihar Suvorau

## Tools

* Programming language [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* Unit testing tool [xUnit.net](https://xunit.net/)
* Version Control System [Git](https://git-scm.com/)
* IDE [Visual Studio](https://visualstudio.microsoft.com/) *optional

## Instruction to reproduce TDD step

1. Download a [release](https://github.com/worraanong/BPMTool_Lab2/releases)  start from version v0.1.1-FAIL and extract files.  
Alternatively, use the Git command to checkout a specific commit `4cb04a2`
1. If Visual Studio is installed, simply double-click on BPMTool.sln
1. The requirement for each TDD cycle is provided in Requirements.txt
1. The entry point of this program is Program.cs, located in BPMTool project.  
To run a program, click on “Run” button or “Ctrl + F5”. A console application should appear.
1. A test file FileValidationTests.cs, is located in BPMTool project.  
To run tests, open a Test explorer and use “Run All Tests In View” button or right-click on a specific test method and select “Run Test(s)”.
1. Without Visual Studio, you can start a program by command line.  
Naviagte to BPMTool_Lab2\BPMTool\BPMTool  
`dotnet run`  
and run tests by navigating to BPMTool_Lab2\BPMTool  
`dotnet test`

## Iterations

|    | Commit       | Release       |
|----| ---------    | -----------   |
|  1 | [[FAIL] - ValidateFileExists](https://github.com/worraanong/BPMTool_Lab2/commit/4cb04a2e53b388ff531cf3d66a4f481b26b670d3) | [v0.1.1-FAIL](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.1.1-FAIL)     |
|  1 | [[PASS] - ValidateFileExists](https://github.com/worraanong/BPMTool_Lab2/commit/b6bffc39480c91e38c755d403ef3927d910b4ad0) | [v0.1.1-PASS](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.1.1-PASS)     |
|  1 | [[REFACTOR] - ValidateFileExists](https://github.com/worraanong/BPMTool_Lab2/commit/53c7486a1a05b9ae6920bc8affa3854b8e51e71c) | [v0.1.2-RFT](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.1.2-RFT)     |
|  2 | [[FAIL] - ValidateFileExtension](https://github.com/worraanong/BPMTool_Lab2/commit/5a93228624f84ca1a3f45a4bbf7d86f82b96e01b) | [v0.2.1-FAIL](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.2.1-FAIL)     |
|  2 | [[PASS] - ValidateFileExtension](https://github.com/worraanong/BPMTool_Lab2/commit/54d2df8f8bffb1355ca0e36acf7b7353c7cc8887) | [v0.2.1-PASS](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.2.1-PASS)     |
|  3 | [[FAIL] - ValidateXESFile](https://github.com/worraanong/BPMTool_Lab2/commit/f16d32bc72e80756735abc6cdfa1664ff6a33a06) | [v0.3.1-FAIL](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.3.1-FAIL)     |
|  3 | [[PASS] - ValidateXESFile](https://github.com/worraanong/BPMTool_Lab2/commit/3346fe28a8d52f13fc73281090e686510fbf9546) | [v0.3.1-PASS](https://github.com/worraanong/BPMTool_Lab2/releases/tag/v0.3.1-PASS)     |

## Executable file

You can make an executable file by build the project. BPMTool.exe will generate inside `bin\` `release` or `debug` based on your selected enviroment.

To run a program, Naviagte to BPMTool_Lab2\BPMTool\BPMTool\bin\Release\netcoreapp3.1

`.\BPMTool.exe "..\..\..\..\Tests\sample.xes"`
