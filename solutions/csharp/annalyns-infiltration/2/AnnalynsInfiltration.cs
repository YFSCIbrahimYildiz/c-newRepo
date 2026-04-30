static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)=> !knightIsAwake;
    

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake==true||archerIsAwake==true||prisonerIsAwake==true){
            return true;
        }
        else{return false;}
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(prisonerIsAwake==true && archerIsAwake == false){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent==true){
            return !archerIsAwake;
        }
        else if((knightIsAwake==false&&archerIsAwake==false)&&prisonerIsAwake==true){
            return true;
        }
        else{
            return false;
        }
    }
}
