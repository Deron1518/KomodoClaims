using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Claims
{
    public int ClaimID { get; set; }
    public TypeOfClaim ClaimType { get; set; }
    public string Description { get; set; }
    public double ClaimAmount { get; set; }
    public DateTime DateOfIncident { get; set; }
    public DateTime DateOfClaim { get; set; }
    public bool IsValid { get; set; }

    public Claims(){}
    public Claims(
        int claimID,
        TypeOfClaim claimType,
        string description,
        double claimAmount,
        DateTime dateOfIncident,
        DateTime dateOfClaim,
        bool isValid
    )
    {
        ClaimID = claimID;
        ClaimType = claimType;
        Description = description;
        ClaimAmount = claimAmount;
        DateOfClaim = dateOfClaim;
        DateOfIncident = dateOfIncident;
        IsValid = isValid;
    }
}
