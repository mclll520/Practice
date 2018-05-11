using System;
using System.Collections.Generic;

public abstract class IGameSystem
{
    public virtual void Init() { }
    public virtual void Update() { }
    public virtual void Release() { }
}

