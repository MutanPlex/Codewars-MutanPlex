public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      int h = 0;
      int m = 0;
      int s = 0;
      string hh = "00";
      string mm = "00";
      string ss = "00";
      string time;
      if(0 <= seconds && seconds <= 359999){
        h = seconds / 3600;
        if(h != 0){
          seconds = seconds - (h * 3600);
        }
          
        m = seconds / 60;
        s = seconds % 60;
      }
      if(h < 10){
        hh = "0" +h;
      }else{
        hh = h.ToString();
      }
      if(m <10){
        mm = "0"+m;
      }else{
        mm = m.ToString();
      }
      if(s < 10){
        ss = "0"+s;
      }else{
        ss = s.ToString();
      }
      time = hh+":"+mm+":"+ss;
      return time;
    }
}