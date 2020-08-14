using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using Core.Utilities.Messages;
using System.Linq;
using Core.CrossCuttingConcerns.Validation;
using Castle.DynamicProxy;

namespace Core.Aspects.Autofac.ValidationAspect
{
	public class ValidationAspect : MethodInterception
	{
		private Type _validatorType;
		public ValidationAspect(Type validatorType)
		{
			if (!typeof(IValidator).IsAssignableFrom(validatorType))
			{
				throw new System.Exception(AspectMessages.WrongValidationType);
			}
			_validatorType = validatorType;
		}

		protected override void OnBefore(IInvocation invocation)
		{
			var validator = (IValidator)Activator.CreateInstance(_validatorType);
			var entityType = _validatorType.BaseType.GetGenericArguments()[0];
			var entityies = invocation.Arguments.Where(t => t.GetType() == entityType);
			foreach (var item in entityies)
			{
				ValidationTool.Validate(validator, item);
			}
		}
	}
}
