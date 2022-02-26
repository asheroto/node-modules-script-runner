# fuk - just freaking run an npm program!!!

Sometimes you just want to run `node_modules\.bin\program.exe` or `node_modules\.bin\program.cmd` without having to mess with symbolic links or versions, right?

Enter `fuk`!!!!!

Named out of frustration with npm / node symbolic link CRAP....

fuk automatically runs the following, whichever exists first....

    node_modules\.bin\program.exe
    node_modules\.bin\program.cmd
    node_modules\.bin\program.bat
    node_modules\.bin\program.ps1

## Prepare for less profanity....

No installation ever!

 - Just copy and paste fuk.exe as many times as needed
- Rename it to the program name such as `program.exe`
 - Place it in `C:\Windows`
 - Repeat

No matter which folder you are in, when you type the name of the program it will automatically check for the existence of `node_modules\.bin\program.exe/cmd/bat/ps1` in the folder you are currently in!

## Example #1 - next.cmd

If you want to run

    node_modules\.bin\next.cmd

Copy `fuk.exe` to C:\Windows and rename it to `next.exe`

Now automatically in EVERY folder it will automatically run `next.cmd` **in respect to the current working directory**. For real!

Meaning....

    cd "C:\Project1"
    next

WORKS
(it runs `C:\Project1\node_modules\.bin\next.cmd`)


    cd "C:\Project2"
    next

WORKS
(it runs `C:\Project2\node_modules\.bin\next.cmd`)

--

You only have to copy `fuk.exe` and rename to `next.exe` one time! It works because `C:\Windows` is in the PATH variable and the name you rename `fuk.exe` to is the name it checks for the existence of **in the node_modules\.bin directory you call it from**!

## Example #2 - strapi.cmd

If you want to run

    node_modules\.bin\strapi.ps1

Copy `fuk.exe` to C:\Windows and rename it to `strapi.exe`

Now automatically in EVERY folder it will automatically run `strapi.cmd` **in respect to the current working directory**. For real!

Meaning....

    cd "C:\Project555"
    strapi

WORKS
(it runs `C:\Project555\node_modules\.bin\strapi.cmd`)


    cd "C:\Project777"
    strapi

WORKS
(it runs `C:\Project777\node_modules\.bin\strapi.cmd`)