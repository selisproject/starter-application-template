var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = y[op[0] & 2 ? "return" : op[0] ? "throw" : "next"]) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [0, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
$(document).keyup(function (event) {
    if (event.which === 123 && event.ctrlKey && event.shiftKey) {
        var debugConsole = new Joove.Widgets.DebugConsole("#debugConsole", "/MasterPage/DebugPage", true);
        debugConsole.minmaxModal(false, null);
    }
});
var DemonstratorApp;
(function (DemonstratorApp) {
    var Controllers;
    (function (Controllers) {
        var _this = this;
        var _treeNodesConfiguration = {};
        var MasterPageConditionalFormattings = [
            new Joove.JbRule({
                name: "PendingChangesMasterConditional",
                type: Joove.RuleTypes.ConditionalFormatting,
                isDataSetRule: false,
                evaluatedAtServer: false,
                contextControlName: null,
                condition: function (_parents) { return __awaiter(_this, void 0, void 0, function () {
                    return __generator(this, function (_a) {
                        return [2 /*return*/, window._context.isDirty];
                    });
                }); },
                evaluationTimes: [Joove.EvaluationTimes.OnLoad, Joove.EvaluationTimes.OnSubmit, Joove.EvaluationTimes.OnChange],
                isRelatedToDataValidation: false
            }),
            new Joove.JbRule({
                name: "HideEmptyTitleMasterConditional",
                type: Joove.RuleTypes.ConditionalFormatting,
                isDataSetRule: false,
                evaluatedAtServer: false,
                contextControlName: null,
                condition: function (_parents) { return __awaiter(_this, void 0, void 0, function () {
                    return __generator(this, function (_a) {
                        return [2 /*return*/, Joove.Common.nullSafe(function () { return CLMS.Framework.String.IsNullOrEmpty(Joove.Common.nullSafe(function () {
                                return Joove.Common.nullSafe(function () { return window["scope_MasterPage"].model.Title; }, "").trim();
                            }, "")); }, false)];
                    });
                }); },
                evaluationTimes: [Joove.EvaluationTimes.OnLoad, Joove.EvaluationTimes.OnSubmit, Joove.EvaluationTimes.OnChange],
                isRelatedToDataValidation: false
            }),
        ];
        var MasterPageDataValidations = [];
        var MasterPageCalculatedExpressions = [];
        var MasterPageController = (function () {
            function MasterPageController($scope, $timeout) {
                var _this = this;
                this.$scope = $scope;
                this.controllerActionFinished = function (resetDirty) {
                    //window.scope_MasterPage.model = window.scope_MasterPage.dehydrate();
                    //
                    DemonstratorApp.ViewModels.MasterPage.MasterPageViewModel._lightCast(window.scope_MasterPage.model);
                    // Joove.Common.applyScope(window.scope_MasterPage);
                    if (resetDirty) {
                        window._context.isDirty = false;
                    }
                    window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
                };
                window.scope_MasterPage = $scope;
                $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
                    Joove.Core.onChange(event.target, newValue, dontMakeDirty);
                };
                $scope._ready = false;
                window._context.currentMasterPageObject = this;
                $scope.dehydrate = function (context) {
                    if (context === void 0) { context = null; }
                    return DemonstratorApp.ViewModels.MasterPage.MasterPageViewModel._initializeFrom($scope.model, context);
                };
                $scope._validations = { summary: []
                };
                var onSuccess = function (data, textStatus, jqXhr) {
                    Joove.Core.checkAppVersion();
                    Joove.Core.handleServerResponse("MasterPage", data);
                    _this.init($scope, $timeout);
                    //Joove.Common.applyScope($scope);
                    //window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {
                    $scope._ready = true;
                    CLMS.Framework.Utilities.FocusOnFirstInputElementOfModal();
                    //});
                }; //end onSuccess()
                window._backEndInfoAggregator.get(false, { success: onSuccess });
            }
            MasterPageController.prototype.init = function ($scope, $timeout) {
                var _this = this;
                $scope.trackObject = function (obj) { return Joove.Common.trackObject(obj); };
                $scope.getRules = function () {
                    {
                        return window.$form._validations;
                    }
                };
                $scope.getModelForDebugConsole = function () {
                    {
                        return Joove.Common.getModel();
                    }
                };
                //}
                $scope.connectedToSignals = function () {
                };
                // Event Listeners
                $scope.events = {};
                $scope.expressions = {};
                // Dataset Handler
                $scope.datasets = {};
                // Controller actions
                $scope.actions = {
                    Render: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            Joove.Core.executeRedirectControllerAction("MasterPage", "Render", "GET", [], {}, _modalOptions);
                            return [2 /*return*/];
                        });
                    }); },
                    SignOut: function (_cb, _modalOptions, _e) { return __awaiter(_this, void 0, void 0, function () {
                        return __generator(this, function (_a) {
                            Joove.Common.autocompleteFix();
                            window._context.isDirty = false;
                            Joove.Core.executeControllerActionNew({
                                verb: 'POST', controller: 'MasterPage', action: 'SignOut',
                                queryData: [], postData: { 'model': $scope.model },
                                cb: _cb, modalOptions: _modalOptions, event: _e
                            });
                            return [2 /*return*/];
                        });
                    }); }
                };
                // Events
                $scope.eventCallbacks = {
                    MainMenuHeaderMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockMainMenuHeaderMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockMainMenuHeaderMenuItemPressed);
                        }
                        _this.timeoutDelayLockMainMenuHeaderMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("HomePage", "Render", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    ManageUsersMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockManageUsersMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockManageUsersMenuItemPressed);
                        }
                        _this.timeoutDelayLockManageUsersMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("UsersList", "Retrieve", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    ManagePermissionsMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockManagePermissionsMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockManagePermissionsMenuItemPressed);
                        }
                        _this.timeoutDelayLockManagePermissionsMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("PermissionsList", "Retrieve", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    ManageRolesMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockManageRolesMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockManageRolesMenuItemPressed);
                        }
                        _this.timeoutDelayLockManageRolesMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("RolesList", "Retrieve", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    ManageOperationsMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockManageOperationsMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockManageOperationsMenuItemPressed);
                        }
                        _this.timeoutDelayLockManageOperationsMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("OperationsList", "Retrieve", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    ManageSettingsMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockManageSettingsMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockManageSettingsMenuItemPressed);
                        }
                        _this.timeoutDelayLockManageSettingsMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("ApplicationSettingsList", "Retrieve", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    MasterChangePasswordMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockMasterChangePasswordMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockMasterChangePasswordMenuItemPressed);
                        }
                        _this.timeoutDelayLockMasterChangePasswordMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("ChangePassword", "Render", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    MasterPreferencesMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockMasterPreferencesMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockMasterPreferencesMenuItemPressed);
                        }
                        _this.timeoutDelayLockMasterPreferencesMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("UserPreferences", "Render", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    MasterSignOutMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockMasterSignOutMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockMasterSignOutMenuItemPressed);
                        }
                        _this.timeoutDelayLockMasterSignOutMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("SignOutPage", "SignOut", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    },
                    MasterSignInMenuItemPressed: function (e, DataItem, _parents) {
                        window._recorder.addState(e);
                        if (e != null) {
                            e.stopPropagation();
                            e.preventDefault();
                        }
                        if (_this.timeoutDelayLockMasterSignInMenuItemPressed != null) {
                            $timeout.cancel(_this.timeoutDelayLockMasterSignInMenuItemPressed);
                        }
                        _this.timeoutDelayLockMasterSignInMenuItemPressed = $timeout(function () {
                            Joove.Common.setControlKeyPressed(e, 0);
                            Joove.Common.setLastClickedElement(e);
                            Joove.Validation.Manager.validateFormAndExecute(function () {
                                //This is true only when the menu item is clicked programmatically
                                //and occurs when the middle mouse button click is triggered
                                var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                                if (openInNewWindow)
                                    $(e.target).data("openInNewWindow", undefined);
                                Joove.Core.executeRedirectControllerAction("SignInPage", "Load", "GET", [], null, null, openInNewWindow);
                            }, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                        }, 0);
                    }
                };
                // Rules
                window._ruleEngine.addDataValidations(MasterPageDataValidations);
                window._ruleEngine.addConditionalFormattings(MasterPageConditionalFormattings);
                window._ruleEngine.addCalculatedExpressions(MasterPageCalculatedExpressions);
                window._commander.executeCommands(window.viewDTO.ClientCommands);
                window.viewDTO.ClientCommands = [];
            };
            return MasterPageController;
        }());
        angular.module("Application").controller("MasterPageController", ["$scope", "$timeout", MasterPageController]);
    })(Controllers = DemonstratorApp.Controllers || (DemonstratorApp.Controllers = {}));
})(DemonstratorApp || (DemonstratorApp = {}));
