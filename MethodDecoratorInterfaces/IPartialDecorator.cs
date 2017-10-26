﻿using System;
using System.Reflection;
using System.Threading.Tasks;

namespace MethodDecorator.Fody.Interfaces
{
    public interface IPartialDecoratorInit1
    {
        void Init(MethodBase iMethod);
    }
    public interface IPartialDecoratorInit2
    {
        void Init(object iInstance,MethodBase iMethod);
    }
    public interface IPartialDecoratorInit3
    {
        void Init(object iInstance, MethodBase iMethod, object[] iParameters);
    }
    public interface IPartialDecoratorEntry
    {
        void OnEntry();
    }
    public interface IPartialDecoratorExit
    {
        void OnExit();
    }
    public interface IPartialDecoratorExit1
    {
        void OnExit(object iRetval);
    }
    public interface IPartialDecoratorException
    {
        void OnException(Exception iException);
    }
    public interface IPartialDecoratorContinuation
    {
        void OnTaskContinuation(Task task);
    }
    public interface IPartialDecoratorNeedBypass
    {
        bool NeedBypass();
    }
    public interface IPartialAlterRetval
    {
        object AlterRetval(object iRetval);
    }
}
