# Quizzer

Quizzer is a card review software for learning just about anything. It supports standard flash cards and multiple choice questions. It uses an SQLite database to save card decks. Decks can be imported and exported.

## Features

- Flash card and multiple choice questions
- Multiple quizzes
- Import/export quizzes to a text file

## Building

Quizzer was written with Visual Studio 2015 targeting .NET Framework 4.5.2 and x64 architecture. The reason for x64 is because the SQLite library bundled with this peoject is x64 only. You can download the x86 version of SQLite to build on x86.

## License

This software is released under the 3-Clause BSD license which can be found in the LICENSE file.