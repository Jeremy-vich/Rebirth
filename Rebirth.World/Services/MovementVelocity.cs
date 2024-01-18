using Rebirth.World.Enums;
using Rebirth.World.Pathfinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Services
{
    public static class MovementVelocity
    {

        public static int GetCellByStop(List<CellWithOrientation> cells, MovementTypeEnum moveType, double time)
        {
            uint velocity = 0;

            foreach (CellWithOrientation cell in cells)
            {
                velocity += GetVelocity(cell, moveType);
                if (velocity > time)
                    return cell.Id;
            }

            return 0;
        }

        public static uint GetPathVelocity(List<CellWithOrientation> cells, MovementTypeEnum moveType)
        {
            uint velocity = 0;

            foreach (CellWithOrientation cell in cells)
            {
                velocity += GetVelocity(cell, moveType);
            }

            return velocity;
        }

        public static uint GetVelocity(CellWithOrientation cell, MovementTypeEnum moveType)
        {
            if (cell.Orientation % 2 == 0)
            {
                if (cell.Orientation % 4 == 0)
                {
                    // HORIZONTAL DIAGONAL VELOCITY

                    switch (moveType)
                    {
                        case MovementTypeEnum.MOUNTED:
                            return 200;
                        case MovementTypeEnum.PARABLE:
                            return 500;
                        case MovementTypeEnum.RUNNING:
                            return 255;
                        case MovementTypeEnum.SLIDE:
                            return 255 * 3;
                        case MovementTypeEnum.WALKING:
                            return 510;

                    }
                }

                // VERTICAL DIAGONAL VELOCITY

                switch (moveType)
                {
                    case MovementTypeEnum.MOUNTED:
                        return 120;
                    case MovementTypeEnum.PARABLE:
                        return 450;
                    case MovementTypeEnum.RUNNING:
                        return 150;
                    case MovementTypeEnum.SLIDE:
                        return 150 * 3;
                    case MovementTypeEnum.WALKING:
                        return 425;
                }
            }

            // LINEAR VELOCITY

            switch (moveType)
            {
                case MovementTypeEnum.MOUNTED:
                    return 135;
                case MovementTypeEnum.PARABLE:
                    return 400;
                case MovementTypeEnum.RUNNING:
                    return 170;
                case MovementTypeEnum.SLIDE:
                    return 170 * 3;
                case MovementTypeEnum.WALKING:
                    return 480;
            }

            return 0;
        }

    }
}
