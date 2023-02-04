﻿using BudgetBadgerWebApi.Application.Logic.Income.Commands;

namespace BudgetBadgerWebApi.Api.ActionParameters.Income
{
    public record CreateIncome
    {
        private string? name;

        public string Name
        {
            get => name;
            set => name = value.Trim().ToLowerInvariant();
        }
        public decimal Value { get; set; }
        public DateTime OccurredAt { get; set; }
        public int CategoryId { get; set; }

        public CreateIncomeCommand GetCreateIncomeCommand(int householdId, int houseMemberId)
            => new(Name, Value, OccurredAt, CategoryId, householdId, houseMemberId);
    }
}
