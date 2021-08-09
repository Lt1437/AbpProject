import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
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
    scope: 'offline_access Project',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'Abp.Project',
    },
  },
} as Environment;
