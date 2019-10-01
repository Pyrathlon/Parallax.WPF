using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallax.WPF.Enum
{
    
    [Flags]
    public enum MouseAwarenessEnum
    {
        Horizontal=1,
        Vertical=2,
        Both=4,      
    }
    [Flags]
    public enum MouseTargetBehaviourEnum
    {        
        Follow = 1,
        Leave = 2
    }
    [Flags]
    public enum MouseTargetGravityPointEnum
    {
        Center = 1,
        Top = 2,
        Right = 4,
        Left = 8,
        Bottom = 16
    }
}
