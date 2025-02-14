﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SciChart.Examples.Demo.ViewModels;

namespace SciChart.Examples.Demo.Helpers.Grouping
{
    public class GroupingByDateReleased: IGrouping
    {
        public GroupingMode GroupingMode { get; set; }

        public GroupingByDateReleased()
        {
            GroupingMode = GroupingMode.DateReleased;
        }

        public ObservableCollection<TileViewModel> GroupingPredicate(IDictionary<Guid, Example> examples)
        {
            var result = new ObservableCollection<TileViewModel>
            {
                new TileViewModel {TileDataContext = new EverythingGroupViewModel {GroupingName = "Most Used"}}
            };

            foreach (var example in examples.Select(x => x.Value))
            {
                result.Add(new TileViewModel { TileDataContext = example });
            }

            return result;
        }
    }
}