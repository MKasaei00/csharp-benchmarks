using System.Reflection;
using PostSharp.Aspects;

namespace HeavyOperationAttributeDemo.Utility;

[Serializable]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class HeavyOperationAttribute : MethodInterceptionAspect
{
    public override void OnInvoke(MethodInterceptionArgs args)
    {
        var methodName = args.Method.Name;
        var className = args.Method.DeclaringType?.Name;
        var classNamespace = args.Method.DeclaringType?.Namespace;
        using var logger = new Logger($"{classNamespace}-{className}-{methodName}");
        args.Proceed();
    }

    public override bool CompileTimeValidate(MethodBase method)
    {
        return true;
    }
}