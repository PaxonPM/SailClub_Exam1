using ClassLibSailClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
public enum EnumStatus
{
    Damaged,
    Ready
}

public class MaintenanceRecord
{
   
    private int nextId;

    public EnumStatus Status { get; private set; } = EnumStatus.Ready;
    public Dictionary<int, string> DamageLog { get; }
    public List<string> MaintenanceLog { get; }


    public MaintenanceRecord()
    {
        DamageLog = new Dictionary<int, string>();
        MaintenanceLog = new List<string>();
    }


    public int AddDamage(string damage)
    {
        if (string.IsNullOrWhiteSpace(damage))
            throw new ArgumentException("Damage must not be empty or whitespace.", nameof(damage));

        nextId++;
        DamageLog[nextId] = damage;
        Status = EnumStatus.Damaged;
        return nextId;
    }

    public void Repair(int damageId)
    {
        if (!DamageLog.TryGetValue(damageId, out var entry))
            throw new KeyNotFoundException($"Damage id {damageId} not found.");

        DamageLog.Remove(damageId);
        MaintenanceLog.Add(entry);

        if (DamageLog.Count == 0)
            Status = EnumStatus.Ready;
    }

}
