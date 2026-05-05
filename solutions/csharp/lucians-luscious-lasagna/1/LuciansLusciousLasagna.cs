class Lasagna
{


    
    public int ExpectedMinutesInOven(){
        return 40;
    }
    public int RemainingMinutesInOven(int dakika){
        return 40-dakika;
    }
    public int PreparationTimeInMinutes(int katman){
        return katman*2;
    }
    public int ElapsedTimeInMinutes(int katman,int dakika){
        return (katman*2)+dakika;
    }
}

