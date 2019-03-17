import * as React from 'react';
import * as ReactDom from 'react-dom';
import { Version } from '@microsoft/sp-core-library';
import { BaseClientSideWebPart } from '@microsoft/sp-webpart-base';
import {
  IPropertyPaneConfiguration,
  PropertyPaneTextField
} from '@microsoft/sp-property-pane';
import * as strings from 'NycscpugDemoWebPartStrings';
import NycscpugDemo from './components/NycscpugDemo';
import { INycscpugDemoProps } from './components/INycscpugDemoProps';
import { AadHttpClientFactory, AadHttpClient, HttpClientResponse } from '@microsoft/sp-http';
export interface INycscpugDemoWebPartProps {
  description: string;
}

export default class NycscpugDemoWebPart extends BaseClientSideWebPart<INycscpugDemoWebPartProps> {

  public render(): void {
    const element: React.ReactElement<INycscpugDemoProps > = React.createElement(
      NycscpugDemo,
      {
        description: this.properties.description,
        context:this.context
      }
    );

    ReactDom.render(element, this.domElement);
  }

  protected onDispose(): void {
    ReactDom.unmountComponentAtNode(this.domElement);
  }

  protected get dataVersion(): Version {
    return Version.parse('1.0');
  }

  protected getPropertyPaneConfiguration(): IPropertyPaneConfiguration {
    return {
      pages: [
        {
          header: {
            description: strings.PropertyPaneDescription
          },
          groups: [
            {
              groupName: strings.BasicGroupName,
              groupFields: [
                PropertyPaneTextField('description', {
                  label: strings.DescriptionFieldLabel
                })
              ]
            }
          ]
        }
      ]
    };
  }
}
