 using System;
using System.Collections.Generic;

/// <summary>
/// 开发角色管理系统、管理所有角色
/// </summary>
public class CharzcterSystem : IGameSystem
{
    private List<ICharacter> _enemies = new List<ICharacter>();
    private List<ICharacter> _soldiers = new List<ICharacter>();


    public void AddEnemy(IEnemy enemy) {
        _enemies.Add(enemy);
    }
    public void RemoveEnemy(IEnemy enemy) {
        _enemies.Remove(enemy);
    }
    public void AddSoldiers(ISoldier soldier) {
        _soldiers.Add(soldier);
    }
    public void RemoveSoldier(ISoldier soldier) {
        _soldiers.Remove(soldier);
    }

    public override void Update()
    {
        UpdateEnemy();
        UpdateSoldier();
    }

    private void UpdateEnemy() {
        foreach (IEnemy e in _enemies)
        {
            e.Update();
            e.UpdateFSMAI(_soldiers);
        }
    }
    private void UpdateSoldier() {
        foreach (ISoldier s in _soldiers)
        {
            s.Update();
            s.UpdateFSMAI(_enemies);
        }
    }
}

