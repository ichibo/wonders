using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public enum Age
    {
        I,
        II,
        III
    }

    [Flags]
    public enum ScienceToken
    {
        Cog = 1,
        Compass = 2,
        Tablet = 4
    }

    [Flags]
    public enum Resource
    {
        Brick = 1,
        Ore = 2,
        Wood = 4,
        Stone = 8,
        Scroll = 16,
        Bottle = 32,
        Wool = 64,
        Any = 128
    }

    [Flags]
    public enum PlayerDirection
    {
        Left = 1,
        Right = 2,
        Any = 4,
        Self = 8,
        LeftRightSelf = Left | Right | Self,
        LeftRight = Left | Right
    }

    public enum CardCategory
    {
        BasicResource, // Brown
        LuxuryResource, // Silver
        Science, // Green
        War, // Red
        Leader, // White
        Debt, // Cities
        Market, // Yellow
        Monument, // Blue
        Guild // Purple
    }
}
