import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinkDetailsFlowComponent } from './link-details-flow.component';

describe('LinkDetailsFlowComponent', () => {
  let component: LinkDetailsFlowComponent;
  let fixture: ComponentFixture<LinkDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LinkDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LinkDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
