﻿namespace Composite
{
    interface IDocumentComponent
    {
        string GatherData();
        void AddComponent(IDocumentComponent documentComponent);
    }
}
