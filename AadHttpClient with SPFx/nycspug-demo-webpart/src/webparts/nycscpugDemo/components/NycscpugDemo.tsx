import * as React from 'react';
import styles from './NycscpugDemo.module.scss';
import { INycscpugDemoProps } from './INycscpugDemoProps';
import { escape } from '@microsoft/sp-lodash-subset';
import { AadHttpClientFactory, AadHttpClient, HttpClientResponse } from '@microsoft/sp-http';

export default class NycscpugDemo extends React.Component<INycscpugDemoProps, {}> {
  public componentDidMount() {
    const appId = "28ec7412-b445-4a98-ab2e-833bcfe87a55"; 
    const apiclient = new AadHttpClient(this.props.context.serviceScope, appId);
    const apiUrl = "https://nyspugdemoapi20190316084607.azurewebsites.net/api/values";
    apiclient.get(apiUrl, AadHttpClient.configurations.v1)
    .then((response: HttpClientResponse): Promise<string[]> => {
      return response.json();
    })
    .then((orders: string[]): void => {
      console.log(orders);
    });
  }

  public render(): React.ReactElement<INycscpugDemoProps> {
    return (
      <div className={ styles.nycscpugDemo }>
        <div className={ styles.container }>
          <div className={ styles.row }>
            <div className={ styles.column }>
              <span className={ styles.title }>Welcome to AAD SharePoint!</span>
              <p className={ styles.subTitle }>Customize SharePoint experiences using Web Parts.</p>
              <p className={ styles.description }>{escape(this.props.description)}</p>
              <a href="https://aka.ms/spfx" className={ styles.button }>
                <span className={ styles.label }>Learn more</span>
              </a>
            </div>
          </div>
        </div>
      </div>
    );
  }
}
