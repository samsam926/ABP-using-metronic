import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Book',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44319',
    redirectUri: baseUrl,
    clientId: 'Book_App',
    responseType: 'code',
    scope: 'offline_access Book',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44319',
      rootNamespace: 'Book',
    },
  },
} as Environment;
