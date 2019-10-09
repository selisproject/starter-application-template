// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_DashboardStatistics: DemonstratorApp.Controllers.IDashboardStatisticsScope; }
namespace DemonstratorApp.Controllers {
const DashboardStatisticsConditionalFormattings = [
        ];
const DashboardStatisticsDataValidations = [
        ];
const DashboardStatisticsCalculatedExpressions = [
        ];

// Datasets Column Info
export var SupplierStatisticDataSet_ColumnInfo = [new Joove.ColumnInfo("Supplier.Company", "string", null, false),
           new Joove.ColumnInfo("DataQuality", "decimal", null, false),
           new Joove.ColumnInfo("DataAvailability", "int", null, false)];
window["SupplierStatisticDataSet_ColumnInfo"] = SupplierStatisticDataSet_ColumnInfo;
export var SupplierStatisticDataSetOnTime_ColumnInfo = [new Joove.ColumnInfo("Supplier.Company", "string", null, false),
           new Joove.ColumnInfo("OnTimeDeliveries", "int", null, false),
           new Joove.ColumnInfo("AsOrderedDeliveries", "int", null, false),
           new Joove.ColumnInfo("InFullDeliveries", "int", null, false),
           new Joove.ColumnInfo("TotalImpeachments", "int", null, false)];
window["SupplierStatisticDataSetOnTime_ColumnInfo"] = SupplierStatisticDataSetOnTime_ColumnInfo;
export var SupplierTurnoverDataSet_ColumnInfo = [new Joove.ColumnInfo("Supplier.Company", "string", null, false),
           new Joove.ColumnInfo("CurrentTurnover", "decimal", null, false),
           new Joove.ColumnInfo("NextTurnover", "decimal", null, false),
           new Joove.ColumnInfo("PreviousTurnover", "decimal", null, false)];
window["SupplierTurnoverDataSet_ColumnInfo"] = SupplierTurnoverDataSet_ColumnInfo;

// Datasets Projection Shemas
window["ChartDataQuality_ProjectionScema"] = {};
window["ChartDataAvailability_ProjectionScema"] = {};
window["Chart_ProjectionScema"] = {};
window["ChartTurnover_ProjectionScema"] = {};


export interface IDashboardStatisticsScope extends Joove.IWebPageScope {
model:
    DemonstratorApp.ViewModels.DashboardStatistics.DashboardStatisticsViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class DashboardStatisticsController {


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_DashboardStatistics.model = window.scope_DashboardStatistics.dehydrate();
        //window.scope_MasterPage.model = window.scope_DashboardStatistics.model;
        DemonstratorApp.ViewModels.DashboardStatistics.DashboardStatisticsViewModel._lightCast(window.scope_DashboardStatistics.model);
        // Joove.Common.applyScope(window.scope_DashboardStatistics);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IDashboardStatisticsScope, $timeout: ng.ITimeoutService) {
        window.scope_DashboardStatistics = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DemonstratorApp.ViewModels.DashboardStatistics.DashboardStatisticsViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IDashboardStatisticsScope, $timeout: ng.ITimeoutService) {


        $scope.model = DemonstratorApp.ViewModels.DashboardStatistics.DashboardStatisticsViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPage.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
ChartDataQualityXScaleMin:
            () => 0,
            ChartDataQualityXScaleMax: () => 100,
                ChartDataQualityXScaleStepSize: () => 25,
                ChartDataAvailabilityXScaleMin: () => 0,
                ChartDataAvailabilityXScaleMax: () => 7,
                ChartDataAvailabilityYScaleMin: () => 0,
                ChartDataAvailabilityYScaleMax: () => 7,
                ChartYScaleMin: () => 0,
                ChartYScaleMax: () => 1000,
                ChartYScaleStepSize: () => 100,
            }
// Dataset Handler
            $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("DashboardStatistics", "Render", "GET", [], {}, _modalOptions);
            },
CloseModal:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {

                    // Joove.Common.applyScope(window.scope_DashboardStatistics);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
        };
// Events
        $scope.eventCallbacks = {
        };

// Rules
        window._ruleEngine.addDataValidations(DashboardStatisticsDataValidations);
        window._ruleEngine.addConditionalFormattings(DashboardStatisticsConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(DashboardStatisticsCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("DashboardStatisticsController", ["$scope", "$timeout", DashboardStatisticsController] as Array<string>);
}
