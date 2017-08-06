﻿using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit.Reactive;
using Xunit;

namespace Octokit.Tests.Integration.Reactive
{
    public class ObservableOrganizationMembersClientTests
    {

        public class TheGetAllPendingInvitesMethod
        {
            readonly ObservableOrganizationMembersClient _client;

            public TheGetAllPendingInvitesMethod()
            {
                _client = new ObservableOrganizationMembersClient(Helper.GetAuthenticatedClient());
            }

            [IntegrationTest]
            public async Task ReturnsNoPendingInvites()
            {
                var pendingInvites = await _client.GetAllPendingInvites(Helper.Organization).ToList();

                Assert.Empty(pendingInvites);
            }
        }
    }
}
