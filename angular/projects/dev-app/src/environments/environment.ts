import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44316/',
  redirectUri: baseUrl,
  clientId: 'Banker_App',
  responseType: 'code',
  scope: 'offline_access Banker',
  requireHttps: true
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Banker',
    logoUrl: '',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44316',
      rootNamespace: 'Usmc.Steward.Banker',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
    Banker: {
      url: 'https://localhost:44309',
      rootNamespace: 'Usmc.Steward.Banker',
    },
  },
} as Environment;
