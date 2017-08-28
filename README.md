[![Chat on Gitter](https://img.shields.io/gitter/room/fody/fody.svg?style=flat)](https://gitter.im/Fody/Fody)
[![NuGet Status](http://img.shields.io/nuget/v/MethodDecorator.Fody.svg?style=flat)](https://www.nuget.org/packages/MethodDecorator.Fody/)

![Icon](https://raw.github.com/Fody/MethodDecorator/master/Icons/package_icon.png)


## The nuget package

https://nuget.org/packages/MethodDecorator.Fody.PP/

    PM> Install-Package MethodDecorator.Fody.PP


## This is an add-in for [Fody](https://github.com/Fody/Fody/) 
## Fork of [MethodDecorator](https://github.com/Fody/MethodDecorator)

Compile time decorator pattern via IL rewriting

[Introduction to Fody](http://github.com/Fody/Fody/wiki/SampleUsage)

### Changes from origin

	* A few bugs fixed
	* Support for an attribute parameters and fields (attribute instantiation procedure now use GetCustomAtributes)
	* OnExit now receiving return value of a method (optional)
	* AspectPriority to alter decoration order for different attribute types
	* Partial decoration to improve performance - any single method of an interceptor can be defined (requires IAspectMatchingRule implementation)
	* Ability to skip actual execution of an intercepted method and substitute the return value (NeedBypass/AlterRetval)
	
### List of possible decoration points

```c#
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
    interface IPartialDecoratorContinuation
    {
        void OnTaskContinuation(Task task);
    }
    interface IPartialDecoratorNeedBypass
    {
        bool NeedBypass();
    }
    interface IPartialAlterRetval
    {
        object AlterRetval(object iRetval);
    }
}

### Recent changes
	
	[0.9.1.4] Moved MethodDecoratorInterfaces.dll into Lib folder - now it will be put into project references when installing the package	
