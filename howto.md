# How to run this code

The code that was posted on Telegram is written in [C# (C Sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/).

It requires DotNet and the Git client to be installed on your machine (win/mac/linux) and any text editor. (been using VSCode)

* [Install DotNet runtime](https://dotnet.microsoft.com/download) - Link to download the installer if it's not already installed... (not going through setup for each environment)
* [Install a Git client](https://git-scm.com/downloads) (using Windows atm, linux/mac could use `apt` or `brew`)
* [Install VSCode](https://code.visualstudio.com/) - Pretty sweet text editor

## Clone/Build/Run the repo

Clone a local repository: (copies the repository files to your local machine from GitHub)

> git clone https://github.com/solatticus/ncswic.git

> cd ncswic

> **dotnet** run

You can play with the parameters for `Epsilon` & `Omega` (provided by the posts), or the `iv` (which is an MD5 hash of a string) using the decrypt method.

# TODO

Main decrypt method signature:

> byte[] **Encrypt**(byte[] **data**, byte[] **key**, byte[] **iv**)

A site/page with 3 textboxes **(so anyone can try combinations)** for:
* **data** *(the string to decrypt, in `byte[]` form)* 
* **key** *(the key used to decrypt, in `byte[]` form)*
* **iv** *(the initialization vector, in `byte[]` form)*

Been using the default `Epsilon` and `Omega` as the `data` parameter, the three `keys` that were originally provided and the IV (initialization vector) set to "`Q Society`". They were copied and pasted from the original telegram posts and result (using Unicode) in a Chinese-ish string. 

## **Looking for help**!