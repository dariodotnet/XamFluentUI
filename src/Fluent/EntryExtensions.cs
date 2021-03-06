﻿using System.Windows.Input;
using Xamarin.Forms;

namespace Fluent
{
    public static class EntryExtensions
    {
        public static Entry CursorPosition(this Entry entry, int position)
        {
            entry.CursorPosition = position;
            return entry;
        }

        public static Entry FontAttributes(this Entry entry, FontAttributes attributes)
        {
            entry.FontAttributes = attributes;
            return entry;
        }

        public static Entry FontFamily(this Entry entry, string fontFamily)
        {
            entry.FontFamily = fontFamily;
            return entry;
        }

        public static Entry FontSize(this Entry entry, double fontSize)
        {
            entry.FontSize = fontSize;
            return entry;
        }

        public static Entry HorizontalTextAlignment(this Entry entry, TextAlignment alignment)
        {
            entry.HorizontalTextAlignment = alignment;
            return entry;
        }

        public static Entry IsPassword(this Entry entry, bool isPassword)
        {
            entry.IsPassword = isPassword;
            return entry;
        }

        public static Entry IsTextPredictionEnabled(this Entry entry, bool enabled)
        {
            entry.IsTextPredictionEnabled = enabled;
            return entry;
        }

        public static Entry ReturnCommand(this Entry entry, ICommand command)
        {
            entry.ReturnCommand = command;
            return entry;
        }

        public static Entry ReturnCommand(this Entry entry, ICommand command, object parameter)
        {
            entry.ReturnCommand = command;
            entry.ReturnCommandParameter = parameter;
            return entry;
        }

        public static Entry ReturnCommandParameter(this Entry entry, object parameter)
        {
            entry.ReturnCommandParameter = parameter;
            return entry;
        }

        public static Entry ReturnType(this Entry entry, ReturnType returnType)
        {
            entry.ReturnType = returnType;
            return entry;
        }

        public static Entry Return(this Entry entry, ReturnType returnType, ICommand command, object paramenter)
        {
            entry.ReturnType = returnType;
            entry.ReturnCommand = command;
            entry.ReturnCommandParameter = paramenter;
            return entry;
        }

        public static Entry SelectionLength(this Entry entry, int length)
        {
            entry.SelectionLength = length;
            return entry;
        }

        public static Entry ClearButtonVisibility(this Entry entry, ClearButtonVisibility visibility)
        {
            entry.ClearButtonVisibility = visibility;
            return entry;
        }

        public static Entry VerticalTextAlignment(this Entry entry, TextAlignment alignment)
        {
            entry.VerticalTextAlignment = alignment;
            return entry;
        }

        public static Entry TextAlignment(this Entry entry, TextAlignment horizontal, TextAlignment vertical)
        {
            entry.HorizontalTextAlignment = horizontal;
            entry.VerticalTextAlignment = vertical;
            return entry;
        }
    }
}