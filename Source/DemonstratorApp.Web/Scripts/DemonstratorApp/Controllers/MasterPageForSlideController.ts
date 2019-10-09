// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;

$(document).keyup((event) => {
    if (event.which === 123 && event.ctrlKey && event.shiftKey) {
        var debugConsole = new Joove.Widgets.DebugConsole("#debugConsole", "/MasterPageForSlide/DebugPage", true);
        debugConsole.minmaxModal(false, null);
    }
});
interface Window { scope_MasterPageForSlide: DemonstratorApp.Controllers.IMasterPageForSlideScope; }
namespace DemonstratorApp.Controllers {
var _treeNodesConfiguration = { };
const MasterPageForSlideConditionalFormattings = [
        ];
const MasterPageForSlideDataValidations = [
        ];
const MasterPageForSlideCalculatedExpressions = [
        ];

// Datasets Column Info

// Datasets Projection Shemas


export interface IMasterPageForSlideScope extends Joove.IWebPageScope {
model:
    DemonstratorApp.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class MasterPageForSlideController {


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_MasterPageForSlide.model = window.scope_MasterPageForSlide.dehydrate();
        //
        DemonstratorApp.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel._lightCast(window.scope_MasterPageForSlide.model);
        // Joove.Common.applyScope(window.scope_MasterPageForSlide);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IMasterPageForSlideScope, $timeout: ng.ITimeoutService) {
        window.scope_MasterPageForSlide = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope._ready = false;
        window._context.currentMasterPageObject = this;
        $scope.dehydrate = (context = null) => DemonstratorApp.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel._initializeFrom($scope.model, context);
        $scope._validations = { summary:
                                [],
                              };

        let onSuccess = (data: any, textStatus: string, jqXhr: JQueryXHR)  => {
            Joove.Core.checkAppVersion();
            Joove.Core.handleServerResponse("MasterPageForSlide", data);
            this.init($scope, $timeout);
            //Joove.Common.applyScope($scope);
            //window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {
            $scope._ready = true;
            CLMS.Framework.Utilities.FocusOnFirstInputElementOfModal();
            //});
        }; //end onSuccess()

        window._backEndInfoAggregator.get(false, { success: onSuccess });

    }

    init($scope: IMasterPageForSlideScope, $timeout: ng.ITimeoutService) {


        $scope.trackObject = obj => Joove.Common.trackObject(obj);
        $scope.getRules = () => {
            {
                return window.$form._validations;
            }
        }
        $scope.getModelForDebugConsole = () => {
            {
                return Joove.Common.getModel();
            }
        }
        //}

        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("MasterPageForSlide", "Render", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
        };

// Rules
        window._ruleEngine.addDataValidations(MasterPageForSlideDataValidations);
        window._ruleEngine.addConditionalFormattings(MasterPageForSlideConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(MasterPageForSlideCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];
    }
}
angular.module("Application").controller("MasterPageForSlideController", ["$scope", "$timeout", MasterPageForSlideController] as Array<string>);
}
