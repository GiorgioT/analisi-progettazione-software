using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercises
{
    class ReverseEngineering
    {

        private async Task<BidTaskStateShow> ShowTaskStateBtn(int roleTypeId, BidTaskNavDTO bidTask)
        {
            var stateShow = new BidTaskStateShow
            {
                ShowCompleteTaskBtn = false,
                WaitingForExecution = false
            };
            switch (roleTypeId)
            {
                case (int)scoreEnums.BidTaskRoleType.Executor:
                    stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Accepted;
                    if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Executed)
                    {
                        stateShow.WaitingForExecution = true;
                        stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Executor;
                        stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                    }
                    break;
                case (int)scoreEnums.BidTaskRoleType.Verifier:
                    var bteamR = await _bidTeamRoleAppService.GetByBidTeamIdAndTypeRoleIdAsync(bidTask.BidTeamId,
                        (int)scoreEnums.BidTeamRoleType.ExCoordinator);
                    if (bteamR != null)
                    {
                        stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.ExApproved;
                        if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.ExApproved)
                        {
                            stateShow.WaitingForExecution = true;
                            stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTeamRoleType.ExCoordinator;
                            stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Team;
                        }
                    }
                    else
                    {
                        stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Executed;
                        if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Executed)
                        {
                            stateShow.WaitingForExecution = true;
                            stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Executor;
                            stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                        }
                    }
                    break;
            }

            return stateShow;
        }

        private async Task<BidTeamStateShow> ShowTeamStateBtn(int roleTypeId, BidTaskNavDTO bidTask)
        {
            var stateShow = new BidTeamStateShow
            {
                ShowCompleteTaskBtn = false,
                WaitingForExecution = false
            };
            switch (roleTypeId)
            {
                case (int)scoreEnums.BidTeamRoleType.ExCoordinator:
                    stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Executed;
                    if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Executed)
                    {
                        stateShow.WaitingForExecution = true;
                        stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Executor;
                        stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                    }
                    break;
                case (int)scoreEnums.BidTeamRoleType.VCoordinator:
                    var btaskR = await _bidTaskRoleAppService.GetByBidTaskIdAndTypeRoleIdAsync(bidTask.Id,
                        (int)scoreEnums.BidTaskRoleType.Verifier);
                    if (btaskR != null)
                    {
                        stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Verified;
                        if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Verified)
                        {
                            stateShow.WaitingForExecution = true;
                            stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Verifier;
                            stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                        }
                    }
                    else
                    {
                        var bteamR = await _bidTeamRoleAppService.GetByBidTeamIdAndTypeRoleIdAsync(bidTask.BidTeamId,
                            (int)scoreEnums.BidTeamRoleType.ExCoordinator);
                        if (bteamR != null)
                        {
                            stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.ExApproved;
                            if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.ExApproved)
                            {
                                stateShow.WaitingForExecution = true;
                                stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTeamRoleType.ExCoordinator;
                                stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Team;
                            }
                        }
                        else
                        {
                            stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Executed;
                            if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Executed)
                            {
                                stateShow.WaitingForExecution = true;
                                stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Executor;
                                stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                            }
                        }
                    }
                    break;
                case (int)scoreEnums.BidTeamRoleType.Inspector:
                    var bteamR1 = await _bidTeamRoleAppService.GetByBidTeamIdAndTypeRoleIdAsync(bidTask.BidTeamId,
                        (int)scoreEnums.BidTeamRoleType.VCoordinator);
                    if (bteamR1 != null)
                    {
                        stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.VerApproved;
                        if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.VerApproved)
                        {
                            stateShow.WaitingForExecution = true;
                            stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTeamRoleType.VCoordinator;
                            stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Team;
                        }
                    }
                    else
                    {
                        var btaskR1 = await _bidTaskRoleAppService.GetByBidTaskIdAndTypeRoleIdAsync(bidTask.BidTeamId,
                            (int)scoreEnums.BidTaskRoleType.Verifier);
                        if (btaskR1 != null)
                        {
                            stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Verified;
                            if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Verified)
                            {
                                stateShow.WaitingForExecution = true;
                                stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Verifier;
                                stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                            }
                        }
                        else
                        {
                            var bteamR2 = await _bidTeamRoleAppService.GetByBidTeamIdAndTypeRoleIdAsync(bidTask.BidTeamId,
                                (int)scoreEnums.BidTeamRoleType.ExCoordinator);
                            if (bteamR2 != null)
                            {
                                stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.ExApproved;
                                if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.ExApproved)
                                {
                                    stateShow.WaitingForExecution = true;
                                    stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTeamRoleType.ExCoordinator;
                                    stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Team;
                                }
                            }
                            else
                            {
                                stateShow.ShowCompleteTaskBtn = bidTask.BidTaskStateId == (int)scoreEnums.BidTaskState.Executed;
                                if (stateShow.ShowCompleteTaskBtn == false && bidTask.BidTaskStateId < (int)scoreEnums.BidTaskState.Executed)
                                {
                                    stateShow.WaitingForExecution = true;
                                    stateShow.WaitingForExecutionRoleId = (int)scoreEnums.BidTaskRoleType.Executor;
                                    stateShow.WaitingRoleTypeId = (int)scoreEnums.RoleFamilyType.Task;
                                }
                            }
                        }
                    }

                    break;
            }
            return stateShow;
        }

        private HomeProducerRolesState GetTasksRoleStatus(long bidTeamId, int bidTaskRoleTypeId, int bidTaskCount)
        {
            var hPES = new HomeProducerRolesState();
            hPES.IconState = "fa-circle";
            hPES.StateColor = "color-blue-grey-lighter";
            hPES.RoleName = L("Dsh_user_no_task", L(Enum.GetName(typeof(scoreEnums.BidTaskRoleType), bidTaskRoleTypeId)) + "<br>");
            var msg = string.Empty;
            var b = _bidTaskLinkedUserAppService.ListByBidTeamId(bidTeamId).Where(x => x.BidTaskRoleTypeId == bidTaskRoleTypeId && x.NominationPositionId == (int)scoreEnums.NominationPosition.FirstChoise && x.NominationStateId == (int)scoreEnums.NominationState.Accepted).ToList();
            if (b.Any() && b.Count() == bidTaskCount)
            {
                hPES.IconState = "fa-check-circle";
                hPES.StateColor = "color-green";
                msg = b.Count() > 1 ? "Dsh_user_andothers_accept_task" : "Dsh_user_accept_task";
            }
            else
            {
                b = _bidTaskLinkedUserAppService.ListByBidTeamId(bidTeamId).Where(x => x.BidTaskRoleTypeId == bidTaskRoleTypeId && x.NominationPositionId == (int)scoreEnums.NominationPosition.FirstChoise && x.NominationStateId == (int)scoreEnums.NominationState.Rejected).ToList();
                if (b.Any() && b.Count() == bidTaskCount)
                {
                    hPES.IconState = "fa-circle";
                    hPES.StateColor = "color-blue-grey-lighter";
                    msg = b.Count() > 1 ? "Dsh_user_andothers_reject_task" : "Dsh_user_reject_task";
                }
            }

            if (b.Any())
            {
                var t = _bidTaskLinkedUserAppService.ListWithIncludeByUserId(b.FirstOrDefault().UserId);
                if (t.FirstOrDefault().User != null)
                {
                    hPES.RoleName = L(msg, t.FirstOrDefault()?.User.FullName + " - ");
                }
            }

            return hPES;
        }

        private HomeProducerRolesState GetTeamsRoleStatus(long bidTeamId, int bidTeamRoleTypeId, int bidTaskCount)
        {
            var hPES = new HomeProducerRolesState();
            hPES.IconState = "fa-circle";
            hPES.StateColor = "color-blue-grey-lighter";
            hPES.RoleName = L("Dsh_user_no_task", L(Enum.GetName(typeof(scoreEnums.BidTeamRoleType), bidTeamRoleTypeId)) + " - ");

            var b = _bidTeamLinkedUserAppService.ListByBidTeamIdWithInclude(bidTeamId).Where(x => x.BidTeamRoleTypeId == bidTeamRoleTypeId && x.NominationPositionId == (int)scoreEnums.NominationPosition.FirstChoise && x.NominationStateId == (int)scoreEnums.NominationState.Accepted).ToList();
            if (b.Any() && b.Count() == bidTaskCount)
            {
                hPES.IconState = "fa-check-circle";
                hPES.StateColor = "color-green";
                hPES.RoleName = L("Dsh_user_accept_task", b.FirstOrDefault().User.FullName + " - ");
            }
            else
            {
                b = _bidTeamLinkedUserAppService.ListByBidTeamIdWithInclude(bidTeamId).Where(x => x.BidTeamRoleTypeId == bidTeamRoleTypeId && x.NominationPositionId == (int)scoreEnums.NominationPosition.FirstChoise && x.NominationStateId == (int)scoreEnums.NominationState.Rejected).ToList();
                if (b.Any() && b.Count() == bidTaskCount)
                {
                    hPES.IconState = "fa-circle";
                    hPES.StateColor = "color-blue-grey-lighter";
                    hPES.RoleName = L("Dsh_user_reject_task", b.FirstOrDefault().User.FullName + " - ");
                }

            }
            return hPES;
        }

        private ProfileProEconomic GetEconomicPro(long userId)
        {
            var year = Clock.Now.Year - 1;
            var upes = _userProfileEconomicAppService.ListByUserIdAsync(userId);
            var ppe = new ProfileProEconomic();
            for (int i = 1; i < 6; i++)
            {
                var dt = new DateTime(year, 1, 1);
                System.Reflection.PropertyInfo _year;
                _year = ppe.GetType().GetProperty("Year_" + i);
                _year.SetValue(ppe, year, new object[0]);
                if (upes.Any(x => x.From == dt))
                {
                    var upe = upes.FirstOrDefault(x => x.From == dt);
                    System.Reflection.PropertyInfo _turnover;
                    _turnover = ppe.GetType().GetProperty("Turnover_" + i);
                    _turnover.SetValue(ppe, upe.Turnover, new object[0]);
                    System.Reflection.PropertyInfo _employees;
                    _employees = ppe.GetType().GetProperty("Employees_" + i);
                    _employees.SetValue(ppe, upe.Employees, new object[0]);
                }

                year -= 1;
            }

            return ppe;
        }

        private async Task<List<string>> GetRolesFromBC(long userId)
        {
            var bcR = new List<string>();
            if (await _executorAppService.IsInRoleBC(userId))
            {
                bcR.Add("Executor");
            }

            if (await _producerAppService.IsInRoleBC(userId))
            {
                bcR.Add("Producer");
            }

            if (await _verifierAppService.IsInRoleBC(userId))
            {
                bcR.Add("Verifier");
            }

            if (await _coordinatorAppService.IsInspectorInRoleBC(userId))
            {
                bcR.Add("Inspector");
            }

            return bcR;
        }

        public async Task<bool> Assign(long bidTaskLinkedUserId, bool writeBC = false)
        {
            var res = false;
            var btd = await _bidTaskLinkedUserAppService.Get(new EntityDto<long>(bidTaskLinkedUserId));
            if (btd != null)
            {
                if (writeBC)
                {
                    var exec = ConstsBcNs.ExecutorNs + "0";
                    var verif = ConstsBcNs.VerifierNs + "0";
                    var produ = ConstsBcNs.ProducerNs + "0";
                    var role = await _roleManager.GetRoleByNameAsync("Producer");
                    var prod = await _bidTeamLinkedUserAppService.GetByBidTeamIdAndRoleIdAsync(btd.BidTeamId, role.Id);
                    if (prod != null)
                    {
                        produ = ConstsBcNs.ProducerNs + prod.UserId;
                    }
                    var checkA = await _clientBC.GetActionAsync(btd.BidTaskId.ToString());
                    switch (btd.BidTaskRoleTypeId)
                    {
                        case (int)scoreEnums.BidTaskRoleType.Executor:
                            if (await _executorAppService.IsInRoleBC(btd.UserId))
                            {
                                exec = ConstsBcNs.ExecutorNs + btd.UserId;
                                if (checkA.verifier != null)
                                {
                                    var posV = checkA.verifier.LastIndexOf("#") + 1;
                                    var idV = checkA.verifier.Substring(posV);
                                    if (btd.UserId == Convert.ToInt64(idV))
                                    {
                                        throw new UserFriendlyException(L("Error_executor_and_verifier_equal"));
                                    }
                                }
                                var assignEx = new AssignActionExecutor
                                {
                                    action = ConstsBcNs.ActionNs + btd.BidTaskId,
                                    executor = exec,
                                    caller = produ,
                                    timestamp = Clock.Now.ToString("u")
                                };
                                await _clientBC.AssignActionExecutorAsync(assignEx);
                            }
                            else
                            {
                                throw new UserFriendlyException("This user cannot operate as EXECUTOR");
                            }
                            break;
                        case (int)scoreEnums.BidTaskRoleType.Verifier:
                            if (await _verifierAppService.IsInRoleBC(btd.UserId))
                            {
                                verif = ConstsBcNs.VerifierNs + btd.UserId;
                                if (checkA.executor != null)
                                {
                                    var posE = checkA.executor.LastIndexOf("#") + 1;
                                    var idE = checkA.executor.Substring(posE);
                                    if (btd.UserId == Convert.ToInt64(idE))
                                    {
                                        throw new UserFriendlyException(L("Error_executor_and_verifier_equal"));
                                    }
                                }

                                var assignVer = new AssignActionVerifier
                                {
                                    action = ConstsBcNs.ActionNs + btd.BidTaskId,
                                    verifier = verif,
                                    caller = produ,
                                    timestamp = Clock.Now.ToString("u")
                                };
                                await _clientBC.AssignActionVerifierAsync(assignVer);
                            }
                            else
                            {
                                throw new UserFriendlyException("This user cannot operate as VERIFIER");
                            }
                            break;
                    }
                    if (exec == verif)
                    {
                        throw new UserFriendlyException("EXECUTOR and VERIFIER cannot be the same");
                    }


                    btd.NominationStateId = (int)scoreEnums.NominationState.Assigned;
                    await _bidTaskLinkedUserAppService.Update(btd);
                    if (btd?.BidTaskRoleTypeId == (int)scoreEnums.BidTaskRoleType.Executor)
                    {
                        await UpdateState(btd.BidTaskId, (int)scoreEnums.BidTaskState.Assigned);
                    }
                    res = true;
                }
            }

            return res;
        }


    }
}
