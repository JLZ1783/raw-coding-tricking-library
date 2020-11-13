﻿using FluentValidation;

namespace TrickingLibrary.Api.Form.Validation
{
    public class CategoryFormValidation : AbstractValidator<CategoryForm>
    {
        public CategoryFormValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}