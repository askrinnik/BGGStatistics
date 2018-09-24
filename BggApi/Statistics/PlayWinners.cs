using System;

namespace BggApi.Statistics
{
  public class PlayWinners
  {
    public string GameName { get; set; }
    public DateTime PlayDate { get; set; }
    public string[] Place1Winners { get; set; }
    public string[] Place2Winners { get; set; }
    public string[] Place3Winners { get; set; }

    public string Place1Winner => string.Join(",", Place1Winners);
    public string Place2Winner => string.Join(",", Place2Winners);
    public string Place3Winner => string.Join(",", Place3Winners);

    public override string ToString()
    {
      return $"{PlayDate} {GameName} {Place1Winner} {Place2Winner} {Place3Winner}";
    }
  }
}
