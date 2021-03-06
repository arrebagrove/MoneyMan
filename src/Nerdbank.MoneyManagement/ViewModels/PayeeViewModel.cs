﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the Ms-PL license. See LICENSE.txt file in the project root for full license information.

namespace Nerdbank.MoneyManagement.ViewModels
{
    using PCLCommandBase;
    using Validation;

    public class PayeeViewModel : BindableBase
    {
        private string name;

        public string Name
        {
            get => this.name;
            set => this.SetProperty(ref this.name, value);
        }

        public void ApplyTo(Payee payee)
        {
            Requires.NotNull(payee, nameof(payee));

            payee.Name = this.name;
        }

        public void CopyFrom(Payee payee)
        {
            Requires.NotNull(payee, nameof(payee));

            this.Name = payee.Name;
        }
    }
}
