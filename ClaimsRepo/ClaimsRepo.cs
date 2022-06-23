using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class ClaimsRepo
{
    private Queue<Claims> _cRepo = new Queue<Claims>();
    // private readonly List<Claims> _cRepo = new List<Claims>();

    public Queue<Claims> GetClaimsInQueue()
    {
        return _cRepo;
    }

    // public List<Claims> GetAllClaims()
    //     {
    //         return _cRepo;
    //     }

    // public bool AddClaimToQueue(Claims claim)
    // {
    //     if(claim != null)
    //     {
    //         _qRepo.Enqueue(claim);
    //         return true;
    //     }

    //     return false;
    // }

    public void AddClaimToQueue(Claims claim)
    {
        _cRepo.Enqueue(claim);
    }

    public bool RemoveClaim()
    {
        Claims claim = ViewNextClaim();
        if(claim is null)
        {
            return false;
        }
        _cRepo.Dequeue();
        return true;
    }

    public Claims ViewNextClaim()
    {
        if(_cRepo.Count > 0)
        {
            Claims claim = _cRepo.Peek();
            return claim;
        }
        return null;
    }

    public void IsValid(Claims claim)
    {
        if(claim.DateOfClaim < claim.DateOfIncident)
            claim.DateOfClaim = claim.DateOfIncident;

        TimeSpan difference = claim.DateOfClaim - claim.DateOfIncident;

        if(difference.Days <= 30)
        {
            claim.IsValid = true;
        }
        else
        {
            claim.IsValid = false;
        }
    }

    

    // public bool AddClaimToList(Claims claim)
    // {
    //     if(claim != null)
    //     {
    //         _cRepo.Add(claim);
    //         return true;
    //     }
    //     return false;
    // }


}
