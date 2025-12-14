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
   
    // Properties
    private int nextId;
    public EnumStatus Status { get; private set; } = EnumStatus.Ready;
    public Dictionary<int, string> DamageLog { get; } = new Dictionary<int, string>();
    public List<string> MaintenanceLog { get; } = new List<string>();


    // Metode som tilføjer skade og returnerer skade-ID
    public int AddDamage(string damage)
    {
        if (string.IsNullOrWhiteSpace(damage))
            throw new ArgumentException("Damage must not be empty or whitespace.", nameof(damage));

        nextId++;
        DamageLog[nextId] = damage;
        Status = EnumStatus.Damaged;
        return nextId;
    }

    // metode som tager sig af reparation af skade baseret på skade-ID
    public void Repair(int damageId)
    {
        if (!DamageLog.TryGetValue(damageId, out var damageText))
            throw new KeyNotFoundException($"Damage id {damageId} not found.");

        DamageLog.Remove(damageId);
        MaintenanceLog.Add(damageText);

        if (DamageLog.Count == 0)
            Status = EnumStatus.Ready;
    }

}
