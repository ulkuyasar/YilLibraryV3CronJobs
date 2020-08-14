using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
	public class ValidationTool
	{
		public static void Validate(IValidator validator, object anyEntity)
		{
			var result = validator.Validate(anyEntity);
			if (!result.IsValid)
			{
				throw new ValidationException(result.Errors);
			}
		}
	}
}
