# AnsiMarkdownLib

[![NuGet](https://img.shields.io/nuget/v/AnsiMarkdownLib.svg?style=flat-square)](https://www.nuget.org/packages/AnsiMarkdownLib)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)

���������� ��� �������������� ������ � �������������� **ANSI-�����** � **Markdown-����������**. ������������ ���������� � **Discord**, �������� ����� ��������� ������� ����������� ���������.

## �������� �����������

- **ANSI-��������������**: ��������� ������, ������� ������, ������������� � ������ ������.
- **Markdown-��������������**: ������ �����, ������, ������������, ������� �����.
- **���������� � Discord**: ANSI-����� ������������� ������������� � ����� ���� ��� Discord.
- **����������� � ����� ������**: ������� ����������� ������������������ ������.

## ���������

���������� ���������� ����� NuGet: https://www.nuget.org/packages/AnsiMarkdownLib/

## ������� �������������

# ANSI-��������������

```csharp
string coloredText = TextFormatter.ApplyAnsiColor("Hello, World!", AvailableColors.Red);
string boldText = TextFormatter.ApplyAnsiBold("Bold Text");
string underlinedText = TextFormatter.ApplyAnsiUnderline("Underlined Text");
```

# Markdown-��������������

```scharp
string boldMarkdown = TextFormatter.ApplyMarkDownBold("Bold Text");
string italicMarkdown = TextFormatter.ApplyMarkDownItalics("Italic Text");
string strikeMarkdown = TextFormatter.ApplyMarkDownStrike("Strike Text");
```

# ���������� � Discord

```scharp
using AnsiMarkdownLib.Builders;

string discordAnsiText = StringBuilderForDiscord.ApplyAnsiColor("Hello, Discord!", AvailableColors.Green);
string discordMarkdownText = StringBuilderForDiscord.ApplyMarkDownBold("Bold Text for Discord");
```

