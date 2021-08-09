<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_NumericGroupInterval/Form1.cs)
* [Numeric Group Interval Function](./CS/Dashboard_NumericGroupInterval/GetNumericGroupIntervalFunction.cs)
<!-- default file list end -->
# Dashboard for WinForms - How to Calculate Numeric Group Interval.

This example shows how to add a custom function, that allows to group data by specified criterion to the WinForm dashboard

## Overview

In this example, the first [Chart](https://docs.devexpress.com/Dashboard/14719/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/chart) dashboard item displays the number of orders for every cost category, and the second Chart displays the total cost for every category.

![screenshot]

The following explression calculates the category of cost.

| Calculated Field| Expression |
| --- | --- |
| Categories of cost | ``` GetNumericGroupInterval([Freight], 100) ``` |

The following code snippet shows how to register numeric group interval function:

```
CriteriaOperator.RegisterCustomFunction(new GetNumericGroupIntervalFunction());
```

## Documentation
- [Interface to work with client mode](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.ICustomFunctionOperatorBrowsable)
- [Interface to work with server mode](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.ICustomFunctionOperatorFormattable)
- [Expression Constants, Operators, and Functions](https://docs.devexpress.com/Dashboard/400122/common-features/advanced-analytics/expression-constants-operators-and-functions)
- [Grouping](https://docs.devexpress.com/Dashboard/116535/common-features/data-shaping/grouping)
