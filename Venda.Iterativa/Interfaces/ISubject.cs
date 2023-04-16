﻿namespace Venda.Iterativa.Interfaces
{
    internal interface ISubject
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}