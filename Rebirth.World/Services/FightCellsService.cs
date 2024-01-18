using Rebirth.Common.GameData.Maps;
using Rebirth.Common.Protocol.Enums;
using Rebirth.World.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Services
{
    public class FightCellsService
    {

    }

    public static class X6X2Template
    {
        public static Dictionary<int, Dictionary<int, List<int>>> GetCells(List<CellData> cells)
        {
            Dictionary<int, Dictionary<int, List<int>>> goodCells = new();

            for (int u = 0; u < 2; u++)
            {
                var cCells = new Dictionary<int, List<int>>();
                var cellsB = cells.FindAll(x => x.Mov && !x.FarmCell).Select(x => new MapPoint((short)x.Id));
                foreach (var cell in cellsB)
                {
                    List<int> list = new() { cell.CellId };
                    var nextCell = cell;
                    if (nextCell == null)
                        continue;
                    for (int i = 0; i < 5; i++)
                    {
                        switch (u)
                        {
                            case 1:
                                nextCell = nextCell.GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_WEST);
                                break;
                            default:
                                nextCell = nextCell.GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_EAST);
                                break;
                        }

                        if (nextCell == null)
                            break;
                        if (cells[nextCell.CellId].Mov && !cells[nextCell.CellId].FarmCell)
                            list.Add(nextCell.CellId);
                    }
                    if (nextCell == null)
                        continue;
                    switch (u)
                    {
                        case 1:
                            nextCell = nextCell.GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_EAST);
                            break;
                        default:
                            nextCell = nextCell.GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_SOUTH_WEST);
                            break;
                    }
                    if (nextCell == null)
                        continue;
                    if (cells[nextCell.CellId].Mov && !cells[nextCell.CellId].FarmCell)
                        list.Add(nextCell.CellId);
                    for (int i = 0; i < 5; i++)
                    {
                        switch (u)
                        {
                            case 1:
                                nextCell = nextCell.GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_NORTH_EAST);
                                break;
                            default:
                                nextCell = nextCell.GetNearestCellInDirection(Common.Protocol.Enums.DirectionsEnum.DIRECTION_NORTH_WEST);
                                break;
                        }
                        if (nextCell == null)
                            break;
                        if (cells[nextCell.CellId].Mov && !cells[nextCell.CellId].FarmCell)
                            list.Add(nextCell.CellId);
                    }
                    if (list.Count == 12)
                        cCells.Add(cell.CellId, list);
                }
                goodCells.Add(u, cCells);
            }


            return goodCells;
        }
    }

    public static class DamierTemplate
    {
        public static Dictionary<int, List<int>> GetCells(List<CellData> cells)
        {
            Dictionary<int, List<int>> goodCells = new();

            var cellsB = cells.FindAll(x => x.Mov && !x.FarmCell).Select(x => new MapPoint((short)x.Id));
            foreach (var cell in cellsB)
            {
                if (cell.CellId + 50 >= 559)
                    continue;
                List<int> list = new() { cell.CellId, cell.CellId + 4};
                list.AddRange(cell.GetAllCellsInRectangle(new MapPoint((short)(cell.CellId + 4))).Select(x => (int)x.CellId));
               
                if (!list.All(x => x >= 0 && x <= 559 && cells[x].Mov && !cells[x].FarmCell))
                    continue;
                goodCells.Add(cell.CellId, list);
            }

            return goodCells;
        }
    }
    public static class LosangeTemplate
    {
        public static Dictionary<int, List<int>> GetCells(List<CellData> cells)
        {
            Dictionary<int, List<int>> goodCells = new();

            var cellsB = cells.FindAll(x => x.Mov && !x.FarmCell).Select(x => new MapPoint((short)x.Id));
            foreach (var cell in cellsB)
            {
                List<int> list = new() { cell.CellId };

                var nextCell = cell;
                if (nextCell == null)
                    continue;
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_WEST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                for (int i = 0; i < 4; i++)
                {
                    nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                    if (nextCell == null)
                        break;
                    list.Add(nextCell.CellId);
                }
                if (nextCell == null)
                    continue;
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_EAST, 3);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                for (int i = 0; i < 4; i++)
                {
                    nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                    if (nextCell == null)
                        break;
                    list.Add(nextCell.CellId);
                }
                if (nextCell == null)
                    continue;
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_WEST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_SOUTH, 4);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                for (int i = 0; i < 4; i++)
                {
                    nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_WEST);
                    if (nextCell == null)
                        break;
                    list.Add(nextCell.CellId);
                }
                if (nextCell == null)
                    continue;
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_WEST, 3);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                for (int i = 0; i < 4; i++)
                {
                    nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_WEST);
                    if (nextCell == null)
                        break;
                    list.Add(nextCell.CellId);
                }
                if (nextCell == null)
                    continue;
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);

                if(list.All(x => cells[x].Mov && !cells[x].FarmCell))
                    goodCells.Add(cell.CellId, list);
            }

            return goodCells;
        }
    }
    public static class CibleTemplate
    {
        public static Dictionary<int, List<int>> GetCells(List<CellData> cells)
        {
            Dictionary<int, List<int>> goodCells = new();

            var cellsB = cells.FindAll(x => x.Mov && !x.FarmCell).Select(x => new MapPoint((short)x.Id));
            foreach (var cell in cellsB)
            {
                List<int> list = new() { cell.CellId };
                // Début route RED
                var nextCell = cell;
                if (nextCell == null)
                    continue;
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST, 2);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_WEST, 3);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST, 2);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                // Début route BLUE
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_WEST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_SOUTH_WEST, 2);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_WEST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_WEST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_NORTH_WEST, 2);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_WEST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST, 2);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_SOUTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);
                nextCell = nextCell.GetNearestCellInDirection(DirectionsEnum.DIRECTION_NORTH_EAST);
                if (nextCell == null)
                    continue;
                list.Add(nextCell.CellId);

                if (!list.All(x => x >= 0 && x <= 559 && cells[x].Mov && !cells[x].FarmCell))
                    continue;
                goodCells.Add(cell.CellId, list);
            }

            return goodCells;
        }
    }
}
