﻿using System;

namespace AutoGestion.Vehicles.State
{
    public class TransfertState
    {
        public ITransfertState State { get; set; } = new Available();

        public void Update()
        {
            State.Handle(this);
        }

        public Type GetTransfertStateType()
        {
            return State.GetType();
        }

        public override string ToString()
        {
            return State.ToString();
        }
    }
}
