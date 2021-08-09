import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Project',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44360',
    redirectUri: baseUrl,
    clientId: 'Project_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone Project',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'Abp.Project',
    },
  },
} as Environment;
