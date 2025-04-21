using System;
using System.Media;
using System.Threading.Tasks;

namespace poeAssigmentTwo.Services;
public class audioService : IDisposable
{
    private SoundPlayer? _player;

    public async Task PlayGreetingAsync()
    {
        try
        {
            _player = new SoundPlayer("C:\\Users\\lab_services_student\\source\\repos\\CLDV_Assign\\CLDV_Assign\\poeAssigmentTwo\\poeAssigmentTwo\\Resources\\p_43541127_331.wav");
            await Task.Run(() => _player.PlaySync());
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync($"[Audio Error] {ex.Message}");
        }
    }

    public void Dispose()
    {
        _player?.Dispose();
    }
}

