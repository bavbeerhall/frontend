﻿

namespace Frontend.Core.ViewModels.Interfaces
{
    using System.Collections.ObjectModel;

    public interface IStepConductorBase
    {
        ObservableCollection<IStep> Steps { get; }

        IStep CurrentStep { get; }

        void MoveToStep(IStep step);
    }
}
