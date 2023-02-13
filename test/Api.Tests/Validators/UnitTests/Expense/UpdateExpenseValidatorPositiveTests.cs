﻿using Api.Tests.Validators.TestData.BudgetChangeEntity.Expense;
using Api.Tests.Validators.TestData.BudgetChangeEntity;
using Api.Tests.Validators.TestData.Common;
using BudgetBadgerWebApi.Api.ActionParameters.Expense;
using BudgetBadgerWebApi.Api.Validators.Expense;
using BudgetBadgerWebApi.Domain.Enums;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tests.Validators.UnitTests.Expense
{
    [Trait("Unit tests", "Validators")]
    public class UpdateExpenseValidatorPositiveTests : ValidatorTestsBase<UpdateExpenseValidator>
    {
        [Theory]
        [EntityCorrectNameData]
        public void Should_Pass_Validation_For_Name(string name)
        {
            var model = new UpdateExpense { Name = name, Value = 100m, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.Name);
        }

        [Theory]
        [BudgetChangeEntityCorrectValueData]
        public void Should_Pass_Validation_For_Value(decimal value)
        {
            var model = new UpdateExpense { Name = "test", Value = value, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.Value);
        }

        [Theory]
        [BudgetChangeEntityCorrectOccurredAtDateData]
        public void Should_Pass_Validation_For_OccurredAt(DateTime occurredAt)
        {
            var model = new UpdateExpense { Name = "test", Value = 100m, OccurredAt = occurredAt, Status = ExpenseStatusEnum.Completed, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.OccurredAt);
        }

        [Theory]
        [ExpenseCorrectStatusData]
        public void Should_Pass_Validation_For_Status(ExpenseStatusEnum status)
        {
            var model = new UpdateExpense { Name = "test", Value = 100m, OccurredAt = DateTime.UtcNow.Date, Status = status, CategoryId = 1 };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.Status);
        }

        [Theory]
        [EntityCorrectIdData]
        public void Should_Pass_Validation_For_CategoryId(int categoryId)
        {
            var model = new UpdateExpense { Name = "test", Value = 100m, OccurredAt = DateTime.UtcNow.Date, Status = ExpenseStatusEnum.Completed, CategoryId = categoryId };
            var result = validator.TestValidate(model);

            result.ShouldNotHaveValidationErrorFor(m => m.CategoryId);
        }
    }
}
