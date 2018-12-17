## Install
Download the latest release for your platform from https://github.com/itofinity/Itofinity-Bitbucket-Refit/releases.

Currently releases for all platforms are in the form of self-contained zips, simply extract the contents to a folder of your choice.

There are _no_ external dependencies.

## Run

### Windows

    >\path\to\install\Itofinity.Bitbucket.Cli.exe

### Linux

    >\path\to\install\Itofinity.Bitbucket.Cli

### macOS

    >\path\to\install\Itofinity.Bitbucket.Cli

Documentation for now refers to the windows .exe version, but it should be simple to adjust.

## Options

The cli is built to be self-explanatory but, its early days, so here are some basics

To access a list of available commands
    
    >Itofinity.Bitbucket.Cli.exe --help

To access help on a specific command
    
    >Itofinity.Bitbucket.Cli.exe {command} --help

To run a specific command
    
    >Itofinity.Bitbucket.Cli.exe {command} -t {apikey} --indent

## Commands

### Porcelain Commands

Porcelain commands are auto-generated from the API client, and return JSON.

Porcelain commands are always available

### Extension Commands

Extension commands potentially provide more nuanced parameters and results, since they can be written to achieve a particular task.

Extension commands are loaded by MEF from the _extensions_ sub-folder.

They are not available if the _extensions_ sub-folder is empty.

_Itofinity.Bitbucket.Cli.Ext_ provides some example extension commands.

### Authentication

The Bitbucket API requires authentication, you need an API Key from https://ci.appveyor.com/api-keys, one that is suitable for the account you are trying to access.

You can provide the key specifically via the token parameter 

    >Itofinity.Bitbucket.Cli.exe {command} -t {apikey}

Or predefine it as an environment variable

    >$env:BITBUCKET_API_TOKEN={apikey}
    >Itofinity.Bitbucket.Cli.exe {command}

### Common options

    --indent

Json output is raw and un-formattted by default, --indent creates formatted output

    --output {filepath}

Output is to the calling console by default, --output redirects to the specified file


    --filter {jsonpath}

Use _jsonpath_ to extract and output only sub-sections, values etc from the main Json response

 ## Examples

    >Itofinity.Bitbucket.Cli --help


    Usage: Itofinity Bitbucket CLI [options] [command]

    Options:
    -?|-h|--help    Show help information
    -v|--verbosity  log verbosity
    -l|--log        log file path

    Commands:
    add-collaborator                      Porcelain command for Add Collaborator Api
    add-environment                       Porcelain command for Add Environment Api
    add-project                           Porcelain command for Add Project Api
    add-role                              Porcelain command for Add Role Api
    add-user                              Porcelain command for Add User Api
    cancel-build                          Porcelain command for Cancel Build Api
    cancel-deployment                     Porcelain command for Cancel Deployment Api
    ...




    >Itofinity.Bitbucket.Cli get-projects --help


    Usage: Itofinity Bitbucket CLI get-projects [options]

    Options:
    -?|-h|--help     Show help information
    -t|--token       An authentication Token
    -i|--indent      Format JSON output
    -o|--outputPath  Redirect output to the specified file
    -f|--filter      Filter JSON output



    >Itofinity.Bitbucket.Cli get-projects -t a1a1a1a1a1a1a1a1a1a
    [{"projectId":147759,"accountName":"mminns","name":"my-project","slug":"my-project","created":"2015-10-15T22:16:45.445205-07:00","accountId":12495,"builds":[{"branch":"master","buildId":1642793, ... }]


    Itofinity.Bitbucket.Cli get-projects -t a1a1a1a1a1a1a1a1a1a --indent
    [
        {
            "projectId": 147759,
            "accountName": "mminns",
            "name": "my-project",
            "slug": "my-project",
            "created": "2015-10-15T22:16:45.445205-07:00",
            "accountId": 12495,
            "builds":  [
                {
                    "branch": "master",
                    "buildId": 1642793,
                    ...
        }
    ]

