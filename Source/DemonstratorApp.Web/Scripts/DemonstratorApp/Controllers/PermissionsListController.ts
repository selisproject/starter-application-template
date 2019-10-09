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
interface Window { scope_PermissionsList: DemonstratorApp.Controllers.IPermissionsListScope; }
namespace DemonstratorApp.Controllers {
const PermissionsListConditionalFormattings = [
        ];
const PermissionsListDataValidations = [
                                       ];
const PermissionsListCalculatedExpressions = [
        ];

// Datasets Column Info
var List_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Name",
caption: window._resourcesManager.getDataListColumnCaption("List", "Name", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 255,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("List", "Description", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 1000,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "bool",
dataTypeIsEnum: false,
name: "IsCustom",
caption: window._resourcesManager.getDataListColumnCaption("List", "IsCustom", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.CHECKBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["List_ColumnInfo"] = List_ColumnInfo;

// Datasets Projection Shemas
window["List_ProjectionScema"] = {};


export interface IPermissionsListScope extends Joove.IWebPageScope {
model:
    DemonstratorApp.ViewModels.PermissionsList.PermissionsListViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class PermissionsListController {
private timeoutDelayLockCreateClicked:
    any;
private timeoutDelayLockEditClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_PermissionsList.model = window.scope_PermissionsList.dehydrate();
        //window.scope_MasterPage.model = window.scope_PermissionsList.model;
        DemonstratorApp.ViewModels.PermissionsList.PermissionsListViewModel._lightCast(window.scope_PermissionsList.model);
        // Joove.Common.applyScope(window.scope_PermissionsList);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IPermissionsListScope, $timeout: ng.ITimeoutService) {
        window.scope_PermissionsList = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DemonstratorApp.ViewModels.PermissionsList.PermissionsListViewModel._initializeFrom($scope.model, context);
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

    init($scope: IPermissionsListScope, $timeout: ng.ITimeoutService) {


        $scope.model = DemonstratorApp.ViewModels.PermissionsList.PermissionsListViewModel._initializeFrom(window.viewDTO.Model);

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
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Refresh:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {
                    Joove.Common.nullSafe<any>(() => window._commander.dataListRefresh(['List']), null);


                    // Joove.Common.applyScope(window.scope_PermissionsList);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
Retrieve:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("PermissionsList", "Retrieve", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
CreateClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockCreateClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockCreateClicked);
                }

                this.timeoutDelayLockCreateClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("ManagePermission", "NewPermission", "GET", [], {}, { mode: 'Slide', width: '50%', height: '50%', onClose: () => { $scope.actions.Refresh(); }});
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

EditClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockEditClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockEditClicked);
                }

                this.timeoutDelayLockEditClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("ManagePermission", "EditPermission", "GET", [Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItem($("[jb-id='List']"), e).Id, 0)], {}, { mode: 'Slide', width: '50%', height: '50%', onClose: () => { $scope.actions.Refresh(); }});
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(PermissionsListDataValidations);
        window._ruleEngine.addConditionalFormattings(PermissionsListConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(PermissionsListCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("PermissionsListController", ["$scope", "$timeout", PermissionsListController] as Array<string>);
}
