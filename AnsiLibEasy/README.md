# AnsiMarkdownLib

[![NuGet](https://img.shields.io/nuget/v/AnsiMarkdownLib.svg?style=flat-square)](https://www.nuget.org/packages/AnsiMarkdownLib)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)

Библиотека для форматирования текста с использованием **ANSI-кодов** и **Markdown-синтаксиса**. Поддерживает интеграцию с **Discord**, позволяя легко создавать красиво оформленные сообщения.

## Основные возможности

- **ANSI-форматирование**: Поддержка цветов, жирного текста, подчеркивания и других стилей.
- **Markdown-форматирование**: Жирный текст, курсив, зачеркивание, скрытый текст.
- **Интеграция с Discord**: ANSI-текст автоматически оборачивается в блоки кода для Discord.
- **Копирование в буфер обмена**: Удобное копирование отформатированного текста.

## Установка

Установите библиотеку через NuGet: https://www.nuget.org/packages/AnsiMarkdownLib/

## Примеры использования

# ANSI-форматирование

```csharp
string coloredText = TextFormatter.ApplyAnsiColor("Hello, World!", AvailableColors.Red);
string boldText = TextFormatter.ApplyAnsiBold("Bold Text");
string underlinedText = TextFormatter.ApplyAnsiUnderline("Underlined Text");
```

# Markdown-форматирование

```scharp
string boldMarkdown = TextFormatter.ApplyMarkDownBold("Bold Text");
string italicMarkdown = TextFormatter.ApplyMarkDownItalics("Italic Text");
string strikeMarkdown = TextFormatter.ApplyMarkDownStrike("Strike Text");
```

# Интеграция с Discord

```scharp
using AnsiMarkdownLib.Builders;

string discordAnsiText = StringBuilderForDiscord.ApplyAnsiColor("Hello, Discord!", AvailableColors.Green);
string discordMarkdownText = StringBuilderForDiscord.ApplyMarkDownBold("Bold Text for Discord");
```

